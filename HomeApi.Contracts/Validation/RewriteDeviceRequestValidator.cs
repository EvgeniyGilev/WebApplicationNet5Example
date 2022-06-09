using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using HomeApi.Contracts.Models.Devices;

namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-валидатор запросов изменения устройства
    /// </summary>
    public class RewriteDeviceRequestValidator : AbstractValidator<RewriteDeviceRequest>
    {
        /// <summary>
        /// Метод, конструктор, устанавливающий правила
        /// </summary>
        public RewriteDeviceRequestValidator()
        {
            /* Зададим правила валидации */
            RuleFor(x => x.NewName).NotEmpty(); // Проверим на null и на пустое свойство
            RuleFor(x => x.NewManufacturer).NotEmpty();
            RuleFor(x => x.NewModel).NotEmpty();
            RuleFor(x => x.NewSerialNumber).NotEmpty();
            RuleFor(x => x.NewCurrentVolts).NotEmpty().InclusiveBetween(120, 220); // Проверим, что значение в заданном диапазоне
            RuleFor(x => x.NewGasUsage).NotNull();
            RuleFor(x => x.NewRoomLocation).NotEmpty().Must(BeSupported).WithMessage($"Please choose one of the following locations: {string.Join(", ", Values.ValidRooms)}");
        }

        /// <summary>
        ///  Метод кастомной валидации для свойства location
        /// </summary>
        private bool BeSupported(string location)
        {
            // Проверим, содержится ли значение в списке допустимых
            return Values.ValidRooms.Any(e => e == location);
        }
    }
}
