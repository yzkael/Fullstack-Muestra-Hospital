import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IMedico } from '../models/interfaces/IMedico';

@Injectable({
  providedIn: 'root'
})
export class MedicosServicesService {

  constructor(private http:HttpClient) { }

  getTodosLosMedicos():Observable<IMedico[]>{
    return this.http.get<IMedico[]>("http://localhost:5195/api/medicos");
  }
}
