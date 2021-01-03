import { ShowsComponent } from "../../../pages/shows/shows.component";
import { ActorLayoutComponent } from "./actor-layout.component";
import { Routes } from "@angular/router";
import { AuthGuard } from "../../../core/guards/auth.guard";

export const ActorLayoutRoutes: Routes = [
  {
    path: "actor",
    component: ActorLayoutComponent,
    canActivate: [AuthGuard],
    canActivateChild: [AuthGuard],
    children: [{ path: "dashbord", component: ShowsComponent }],
  },
];
