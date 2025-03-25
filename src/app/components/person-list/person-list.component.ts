import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-person-list',
  templateUrl: './person-list.component.html',
  styleUrls: ['./person-list.component.scss']
})
export class PersonListComponent {
  persons = [
    { id: 1, fullName: 'John Doe', address: '123 Main St', city: 'New York', state: 'NY', zipCode: '10001', phoneNumber: '123-456-7890' },
    { id: 2, fullName: 'Jane Smith', address: '456 Elm St', city: 'Los Angeles', state: 'CA', zipCode: '90012', phoneNumber: '987-654-3210' }
  ];

  constructor(private router: Router) {}

  openForm() {
    this.router.navigate(['/add-person']); // Navigate to Add Person Page
  }

  editPerson(id: number) {
    alert(`Edit person with ID: ${id}`);
  }

  deletePerson(id: number) {
    this.router.navigate(['/edit-person', id]); // Navigate to edit page with ID
    alert(`Deleted person with ID: ${id}`);
  }
}
