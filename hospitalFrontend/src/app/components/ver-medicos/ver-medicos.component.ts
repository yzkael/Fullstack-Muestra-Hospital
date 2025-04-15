import { Component, inject, OnInit } from '@angular/core';
import { MedicosServicesService } from '../../services/medicos-services.service';
import { CommonModule } from '@angular/common';
import { IMedico } from '../../models/interfaces/IMedico';

@Component({
  selector: 'app-ver-medicos',
  imports: [CommonModule],
  templateUrl: './ver-medicos.component.html',
  styleUrl: './ver-medicos.component.css'
})
export class VerMedicosComponent implements OnInit  {
  listaMedicos:IMedico[] = []
  medicoService = inject(MedicosServicesService)
  ngOnInit(): void {
      this.medicoService.getTodosLosMedicos().subscribe((medicos)=>{
        console.log(medicos)
      this.listaMedicos = medicos
    })
  }
}