using System.Reflection;

namespace ReqFieldsPOC.Validations
{
    public class Validator
    {
        public ValidationResult Validate(object obj)
        {
            var missingFields = new List<string>();
            if (obj == null)
            {
                return new ValidationResult()
                {
                    IsValid = false,
                    MissingFields = missingFields
                };
            }

            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                missingFields.AddRange(ValidateProperty(obj, property));
            }

            return new ValidationResult()
            {
                IsValid = !missingFields.Any(),
                MissingFields = missingFields
            };
        }


        private IEnumerable<string> ValidateProperty(object obj, PropertyInfo property, string parentPath = "", HashSet<string> validatedPaths = null)
        {
            var missingFields = new List<string>();
            var attrs = property.GetCustomAttributes<RequiredFieldPathAttribute>();

            foreach (var attr in attrs)
            {
                var value = property.GetValue(obj);
                var fullPath = ConstructFullPath(property.Name, parentPath);

                if (attr.Path == null || string.IsNullOrEmpty(attr.Path))
                {
                    if (value == null || IsStringEmpty(value))
                    {
                        missingFields.Add(fullPath);
                    }
                }
                else
                {
                    var paths = attr.Path.Split('.');
                    ValidatePaths(value, paths, missingFields, fullPath);
                }

                if (IsComplexType(property.PropertyType))
                {
                    validatedPaths ??= new HashSet<string>();
                    if (validatedPaths.Add(fullPath))
                    {
                        missingFields.AddRange(Validate(value).MissingFields.Select(m => $"{fullPath}.{m}"));
                    }
                }
            }

            return missingFields;
        }


        private string ConstructFullPath(string propertyName, string parentPath)
        {
            return string.IsNullOrEmpty(parentPath) ? propertyName : $"{parentPath}.{propertyName}";
        }

        private void ValidatePaths(object value, IEnumerable<string> paths, List<string> missingFields, string fullPath)
        {
            var currentPath = fullPath;
            foreach (var part in paths)
            {
                if (value == null)
                {
                    missingFields.Add(currentPath);
                    break;
                }

                var subProperty = value.GetType().GetProperty(part);
                value = subProperty?.GetValue(value);
                currentPath = $"{currentPath}.{part}";

                if (value == null || IsStringEmpty(value))
                {
                    missingFields.Add(currentPath);
                }
            }
        }

        private bool IsStringEmpty(object value)
        {
            return value is string str && string.IsNullOrEmpty(str);
        }

        private bool IsComplexType(Type type)
        {
            return !type.IsPrimitive && type != typeof(string);
        }
    }

}
