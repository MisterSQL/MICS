// Class representing a branch or filial
export class Filial {
    // Static property to store a list of all filials
    static listFilial = [];

    // Constructor to initialize a filial with a name and an empty list of departments
    constructor(name) {
        this.name = name;
        this.departments = [];

        // Add the newly created filial to the list of all filials
        Filial.listFilial.push(this);
    }

    // Method to add a department to the filial
    addDepartment(depart) {
        this.departments.push(depart);
    }

    // Method to remove a department from the filial
    removeDepartment(depart) {
        // Find the index of the department in the list of departments
        const index = this.departments.indexOf(depart);

        // If the department is found, remove it from the list
        if (index !== -1) {
            this.departments.splice(index, 1);
        }
    }
}