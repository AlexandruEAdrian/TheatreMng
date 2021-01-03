import { Routes } from "@angular/router";
import { ActorManagementComponent } from "../../../pages/actor-management/actor-management.component";
import { DirectorLayoutComponent } from "./director-layout.component";
import { ShowsManagementComponent } from "../../../pages/show-management/shows-management.component";
import { AuthGuard } from "../../../core/guards/auth.guard";

export const DirectorLayoutRoutes: Routes = [
  {
    path: "boss",
    component: DirectorLayoutComponent,
    canActivate: [AuthGuard],
    children: [
      { path: "actor-management", component: ActorManagementComponent },
      { path: "shows-management", component: ShowsManagementComponent },
    ],
  },
];
