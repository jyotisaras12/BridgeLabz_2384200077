import { Injectable } from '@angular/core';
import { Person } from '../models/person.model';

@Injectable({
  providedIn: 'root'
})
export class PersonService {
  private persons: Person[] = [];

  constructor() {}

  getPersons(): Person[] {
    return this.persons;
  }

  addPerson(person: Person) {
    this.persons.push({ ...person, id: this.persons.length + 1 });
  }

  deletePerson(id: number) {
    this.persons = this.persons.filter(person => person.id !== id);
  }

  getPersonById(id: number): Person | undefined {
    return this.persons.find(person => person.id === id);
  }
}
