// Importing required classes and styles
import {Filial} from './Filial';
import {Department} from './Departament';
import {Group} from "./Group";
import {Employee} from './Employer';
import "./style.css";

// Objects to store instances of different classes
const filials = {};
const departaments = {}
const groups = {}
const employees = {}
const objectArrEmployer = {}

// DOM elements
const selectFilial = document.getElementById("selectFilial");
const depListId = document.getElementById("depListId");
const depGroup = document.getElementById("depGroup")
const depEmployee = document.getElementById("depEmploy")
const containerEmployee = document.getElementById("containerEmployee")
const content = document.getElementById("content");
// Adding event listeners

content.addEventListener('click',addOrRemoveElement)
depListId.addEventListener("change", updateDepGroupOptions);
selectFilial.addEventListener("change",(chooseFilial));
depGroup.addEventListener("change", updateEmployeers);

// Event listener for the "change" event on depEmployee dropdown
depEmployee.addEventListener("change",()=>{
    showEmployer(depEmployee.value)
})

// Function to add a new filial
function addFilial(){
    // Get the name of the filial from the input field
    const nameFilial = document.getElementById("addFilial")
    filials[nameFilial.value] = new Filial(nameFilial.value)
    addOption(nameFilial.value,selectFilial);
    // Clear the input field
    nameFilial.value = "";
}

// Function to add a new department
function addDepartament(){
    const nameDepartment = document.getElementById("nameDepartament");
    departaments[nameDepartment.value] = new Department(nameDepartment.value);
    const currentFelial = filials[selectFilial.options[selectFilial.selectedIndex].text];
    currentFelial.addDepartment(departaments[nameDepartment.value])
    addOption(nameDepartment.value,depListId)
    // Clear the input field
    nameDepartment.value = "";
}

// Function to handle adding or removing elements based on the clicked element
function addOrRemoveElement(event){
    const element = event.target;
    const className = element.className;
    const functionName = element.dataset.action;
    console.log(className)
    if(className === "remove"){
        if(functionName === removeDepartament.name){
            removeDepartament()
        }else if(functionName===removeGroup.name){
            removeGroup();
        }

    }else if(className === "add"){
        if(functionName === addGroupList.name){
            addGroupList();
        }else if(functionName === addEmployerList.name){
            addEmployerList()
        }else if(functionName === addDepartament.name){
            addDepartament();
        }else if(functionName === addFilial.name){
            addFilial();
        }
    }
}

// Function to add a new group
function addGroupList() {
    // Get the name of the group from the input field
    const nameGroup = document.getElementById("addGroup");

    // Create a new Group instance and add it to the groups object
    groups[nameGroup.value] = new Group(nameGroup.value);

    // Get the currently selected department
    const currentDepartment = departaments[depListId.options[depListId.selectedIndex].text];

    // Add the new group to the current department
    currentDepartment.addGroup(groups[nameGroup.value]);

    // Add a new option to the depGroup dropdown
    addOption(nameGroup.value, depGroup);

    // Clear the input field
    nameGroup.value = "";
}

// Function to add a new employer
function addEmployerList() {
    // Get the input value containing information about the employer and split it into an array
    const infoEmployer = document.getElementById("addEmployer").value.split("/");

    // Create a new Employee instance and add it to the employees object
    employees[infoEmployer[0]] = new Employee(infoEmployer[0], infoEmployer[1], infoEmployer[2]);

    // Create an entry in the objectArrEmployer to store employer information
    objectArrEmployer[infoEmployer[0]] = [infoEmployer[0], infoEmployer[1], infoEmployer[2]];

    // Get the currently selected group
    const currentGroup = groups[depGroup.options[depGroup.selectedIndex].text];

    // Add the new employee to the current group
    currentGroup.addEmployee(employees[infoEmployer[0]]);

    // Add a new option to the depEmployee dropdown
    addOption(infoEmployer[0], depEmployee);

    // Show details of the newly added employer
    showEmployer(infoEmployer[0]);

    // Clear the input field
    const clearHost = document.getElementById("addEmployer");
    clearHost.value = "";
}

// Function to add a new option to a dropdown menu
function addOption(name, parent) {
    // Create a new option element
    const option = document.createElement("option");

    // Set the display text of the option
    option.innerText = name;

    // Set the value attribute of the option
    option.setAttribute("value", name);

    // Append the option to the specified parent (dropdown menu)
    parent.append(option);
}


// Function to update depListId dropdown based on the selected filial
function chooseFilial() {
    // Clear the current options in the depListId dropdown
    depListId.innerHTML = "";

    // Iterate through all filials in the list
    for (let i = 0; i < Filial.listFilial.length; i++) {
        // Check if the current filial's name matches the selected filial
        if (Filial.listFilial[i].name === selectFilial.value) {
            // Iterate through the departments of the current filial
            for (let j = 0; j < Filial.listFilial[i].departments.length; j++) {
                // Create a new option element for each department and add it to depListId
                const option = document.createElement('option');
                option.innerHTML = Filial.listFilial[i].departments[j].name;
                depListId.append(option);
            }
        }
    }

    // Update other UI elements and options
    updateDepGroupOptions();
    showEmployer(depEmployee.value);
    updateEmployeers();
}

// Function to update depGroup dropdown based on the selected department
function updateDepGroupOptions() {
    // Clear the current options in the depGroup dropdown
    depGroup.innerHTML = "";

    // Iterate through all departments in the list
    for (let i = 0; i < Department.listDepartments.length; i++) {
        // Check if the current department's name matches the selected department
        if (Department.listDepartments[i].name === depListId.value) {
            // Iterate through the groups of the current department
            for (let j = 0; j < Department.listDepartments[i].groups.length; j++) {
                // Create a new option element for each group and add it to depGroup
                const option = document.createElement('option');
                option.innerHTML = Department.listDepartments[i].groups[j].name;
                depGroup.append(option);
            }
        }
    }

    // Update other UI elements and options
    showEmployer(depEmployee.value);
    updateEmployeers();
}


// Function to update depEmployee dropdown based on the selected group
function updateEmployeers() {
    // Clear the current options in the depEmployee dropdown
    depEmployee.innerHTML = "";

    // Iterate through all groups in the list
    for (let i = 0; i < Group.listGroups.length; i++) {
        // Check if the current group's name matches the selected group
        if (Group.listGroups[i].name === depGroup.value) {
            // Iterate through the employees of the current group
            for (let j = 0; j < Group.listGroups[i].employees.length; j++) {
                // Create a new option element for each employee and add it to depEmployee
                const option = document.createElement('option');
                option.innerHTML = Group.listGroups[i].employees[j].name;
                depEmployee.append(option);
            }
        }
    }

    // Show details of the currently selected employee
    showEmployer(depEmployee.value);
}


// Function to display details about an employer in the container
function showEmployer(infoEmployer) {
    // Check if infoEmployer is an empty string
    if (infoEmployer === "") {
        // If it is empty, clear the container
        containerEmployee.innerHTML = "";
    } else {
        // Clear the container
        containerEmployee.innerHTML = "";

        // Create a new div element for the employer details
        const boxEmployee = document.createElement("div");
        boxEmployee.setAttribute("class", "boxEmployee");

        // Iterate through the employer details
        for (let i = 0; i < objectArrEmployer[infoEmployer].length; i++) {
            // Check if the current detail is not the salary
            if (i !== 2) {
                // Create a paragraph element for non-salary details and append it to the boxEmployee
                const p = document.createElement("p");
                p.innerHTML = objectArrEmployer[infoEmployer][i];
                boxEmployee.append(p);
            } else {
                // Create an input element for the salary and append it to the boxEmployee
                const salary = document.createElement("input");
                salary.value = objectArrEmployer[infoEmployer][i];
                salary.setAttribute("id", "salary");
                boxEmployee.append(salary);
            }
        }

        // Create buttons for firing the employee and changing the salary
        const fireEmployeeButton = document.createElement("button");
        const changeSalaryButton = document.createElement("button");

        // Add event listeners to the buttons
        fireEmployeeButton.addEventListener("click", fireEmployee);
        fireEmployeeButton.setAttribute("class", "remove");

        changeSalaryButton.addEventListener("click", changeSalary);

        // Set button labels
        fireEmployeeButton.innerHTML = "X";
        changeSalaryButton.innerHTML = "Change Salary";

        // Append buttons to the boxEmployee
        boxEmployee.append(fireEmployeeButton);
        boxEmployee.append(changeSalaryButton);

        // Append boxEmployee to the containerEmployee
        containerEmployee.append(boxEmployee);
    }
}

function changeSalary(){
    const newSalary = document.getElementById("salary");
    employees[depEmployee.value].salary = newSalary.value;
    objectArrEmployer[depEmployee.value][2] = newSalary.value;
}
function removeDepartament() {
    while (depGroup.value !== ""){
        removeGroup()
    }
    filials[selectFilial.value].removeDepartment(depListId.value)
    delete departaments[depListId.value]
    const selectOption = depListId.options[depListId.selectedIndex]
    removeSelectOption(selectOption)
}

function removeGroup(){
    while (depEmployee.value !== ""){
        fireEmployee()
    }
    departaments[depListId.value].removeGroup(depGroup.value)
    delete groups[depGroup.value]
    const selectOption = depGroup.options[depGroup.selectedIndex]
    removeSelectOption(selectOption)
}

function fireEmployee(){
    containerEmployee.innerHTML = "";
    groups[depGroup.value].removeEmployee(depEmployee.value)
    delete employees[depEmployee.value]
    delete objectArrEmployer[depEmployee.value]
    const selectOption = depEmployee.options[depEmployee.selectedIndex]
    removeSelectOption(selectOption)
}
function removeSelectOption(selectOption){
    if(selectOption){
        selectOption.remove()
    }
}