import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { DirectorLayoutComponent } from "./director-layout.component";
import { ShowsManagementComponent } from "../../../pages/show-management/shows-management.component";
import { ActorManagementComponent } from "../../../pages/actor-management/actor-management.component";
import { RouterModule } from "@angular/router";
import { DirectorLayoutRoutes } from "./director-layout.routing";

const componentsArray = [
  DirectorLayoutComponent,
  ShowsManagementComponent,
  ActorManagementComponent,
];

@NgModule({
  declarations: componentsArray,
  imports: [CommonModule, RouterModule.forChild(DirectorLayoutRoutes)],
  exports: componentsArray,
})
export class DirectorLayoutModule {}
