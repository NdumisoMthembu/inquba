import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DrinkMakerComponent } from './drink-maker/drink-maker.component';


const routes: Routes = [
  {
    path: 'drinks', component: DrinkMakerComponent
  },
  {
    path: '', component: DrinkMakerComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
