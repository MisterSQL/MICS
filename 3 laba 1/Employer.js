// Class representing an employee
export class Employee {
    // Constructor to initialize an employee with a name, profession, and salary
    constructor(name, profession, salary) {
        this.name = name;
        this.profession = profession;
        this.salary = salary;
    }

    // Method to change the salary of the employee
    changeSalary(newSalary) {
        this.salary = newSalary;
    }
}