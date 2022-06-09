using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Contracts.Models.Devices.Validators
{
    public class AddDeviceRequestValidator : AbstractValidator<AddDeviceRequest>
    {
        public AddDeviceRequestValidator()
        {
            RuleFor(x => x.CurrentVolts).
                NotEmpty()
                .Must(BeValidCurrentVolts)
                .WithMessage("Напряжение у устройства должно быть от 120 до 220 В!");

        }

        // [Range(120, 220, ErrorMessage = "Поддерживаются устройства с напряжением от {1} до {2} вольт")]
        public bool BeValidCurrentVolts(int volts)
        {
            if (volts < 120)
                return false;
            if (volts > 220)
                return false;

            return true;

        }
    }
}
