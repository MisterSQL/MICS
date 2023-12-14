// Class representing a group
export class Group {
    // Static property to store a list of all groups
    static listGroups = [];

    // Constructor to initialize a group with a name and an empty list of employees
    constructor(name) {
        this.name = name;
        this.employees = [];

        // Add the newly created group to the list of all groups
        Group.listGroups.push(this);
    }

    // Method to add an employee to the group
    addEmployee(employee) {
        this.employees.push(employee);
    }

    // Method to remove an employee from the group
    removeEmployee(employee) {
        // Find the index of the employee in the list of employees
        const index = this.employees.indexOf(employee);

        // If the employee is found, remove it from the list
        if (index !== -1) {
            this.employees.splice(index, 1);
        }
    }
}   