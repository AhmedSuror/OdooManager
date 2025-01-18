using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace OdooManager.Model;

public class ConnectionVM
{
    public string Server { get; set; }
    public string Database { get; set; }
    public string UserName{ get; set; }
    public string Password{ get; set; }
}

public class ConnectionValidator : AbstractValidator<ConnectionVM>
{
    public ConnectionValidator()
    {
        RuleFor(c => c.Server)
            .NotEmpty()
            .WithMessage("Please enter server IP or FQDN.");

        RuleFor(c => c.Database)
            .NotEmpty()
            .WithMessage("Please enter Postgre database name.");
        
        RuleFor(c => c.UserName)
            .NotEmpty()
            .WithMessage("Please enter Postgre database username.");

        RuleFor(c => c.Password)
            .NotEmpty()
            .WithMessage("Please enter Postgre database password.");


    }
}