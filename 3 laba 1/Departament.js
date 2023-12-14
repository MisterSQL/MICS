// Class representing a department
export class Department {
    // Static property to store a list of all departments
    static listDepartments = [];

    // Constructor to initialize a department with a name and an empty list of groups
    constructor(name) {
        this.name = name;
        this.groups = [];

        // Add the newly created department to the list of all departments
        Department.listDepartments.push(this);
    }

    // Method to add a group to the department
    addGroup(group) {
        this.groups.push(group);
    }

    // Method to remove a group from the department
    removeGroup(group) {
        // Find the index of the group in the list of groups
        const index = this.groups.indexOf(group);

        // If the group is found, remove it from the list
        if (index !== -1) {
            this.groups.splice(index, 1);
        }
    }
}