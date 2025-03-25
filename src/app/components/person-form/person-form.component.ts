import { Component } from '@angular/core';

@Component({
  selector: 'app-person-form',
  templateUrl: './person-form.component.html',
  styleUrls: ['./person-form.component.scss']
})
export class PersonFormComponent {
  person: any = {
    fullName: '',
    phoneNumber: '',
    address: '',
    city: '',
    state: '',
    zipCode: ''
  };

  savePerson() {
    console.log('Person saved:', this.person);
  }
}
