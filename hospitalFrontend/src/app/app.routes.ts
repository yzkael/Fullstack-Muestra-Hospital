import { Routes } from '@angular/router';
import { InicioComponent } from './components/inicio/inicio.component';
import { VerMedicosComponent } from './components/ver-medicos/ver-medicos.component';

export const routes: Routes = [
    {
        path:'',
        component: InicioComponent
        
    },
    {
        path:'ver-medicos', 
        component: VerMedicosComponent
    }
];
