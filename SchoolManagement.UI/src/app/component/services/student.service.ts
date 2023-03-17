import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Student } from '../models/student'

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private http: HttpClient) { }
  url = "http://localhost:5035/";
  getStudentList(): Observable<Student[]> {
    return this.http.get<Student[]>(`${this.url}api/Students`);
  }
s
  getStudentById(id: number): Observable<Student> {
    return this.http.get<Student>(`${this.url}api/Students/${id}`);
  }
  postStudent(data: Student): Observable<Student> {
    return this.http.post<Student>(`${this.url}api/Students`, data);
  }
  putStudent(data: Student): Observable<any> {
    return this.http.put<any>(`${this.url}api/Students/${data.id}`, data);
  }
  deleteStudent(id: number): Observable<Student> {
    return this.http.delete<Student>(`${this.url}api/Students/${id}`);
  }
}
