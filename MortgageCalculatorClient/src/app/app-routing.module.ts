import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'home',
    loadChildren: () => import('./home/home.module').then( m => m.HomePageModule)
  },
  {
    path: '', 
    redirectTo: 'mortgagecalculator', //the same as the page file
    pathMatch: 'full'
  },
  {
    path: 'mortgagecalculator',
    loadChildren: () => import('./mortgagecalculator/mortgagecalculator.module').then( m => m.MortgagecalculatorPageModule)
  },

];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
