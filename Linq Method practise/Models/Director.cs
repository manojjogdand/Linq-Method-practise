﻿namespace Linq_Method_practise.Models;

public class Director : Employee
{
    public string Permissions { get; set; } = string.Empty;
    public bool AbleToHire { get; set; } = false;
    public string DepartmentResponsibleFor { get; set; } = string.Empty;
}
