import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ActorLayoutComponent } from "./actor-layout.component";
import { ShowsComponent } from "../../../pages/shows/shows.component";
import { RouterModule } from "@angular/router";
import { ActorLayoutRoutes } from "./actor-layout.routing";

const componentsArray = [ActorLayoutComponent, ShowsComponent];

@NgModule({
  declarations: componentsArray,
  imports: [CommonModule, RouterModule.forChild(ActorLayoutRoutes)],
  exports: componentsArray,
})
export class ActorLayoutModule {}
