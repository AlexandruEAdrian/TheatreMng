import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { RouterModule } from "@angular/router";

import { AppComponent } from "./app.component";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { HomeComponent } from "./pages/home/home.component";
import {
  MatCardModule,
  MatListModule,
  MatToolbarModule,
} from "@angular/material";
import { AuthLayoutComponent } from "./shared/layouts/auth-layout/auth-layout.component";
import { ActorLayoutComponent } from "./shared/layouts/actor-layout/actor-layout.component";
import { DirectorLayoutComponent } from "./shared/layouts/director-layouts/director-layout.component";
import { AuthGuard } from "./core/guards/auth.guard";
import { AuthLayoutModule } from "./shared/layouts/auth-layout/auth-layout.module";
import { ActorLayoutModule } from "./shared/layouts/actor-layout/actor-layout.module";
import { DirectorLayoutModule } from "./shared/layouts/director-layouts/director-layout.module";
import { ToastrModule } from "ngx-toastr";
import { NavMenuComponent } from "./nav-menu/nav-menu.component";
@NgModule({
  declarations: [AppComponent, NavMenuComponent, HomeComponent],
  imports: [
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    HttpClientModule,
    FormsModule,
    AuthLayoutModule,
    ActorLayoutModule,
    DirectorLayoutModule,
    ToastrModule.forRoot(),
    RouterModule.forRoot([
      { path: "", component: HomeComponent, pathMatch: "full" },
      { path: "**", component: HomeComponent, pathMatch: "full" },
      {
        path: "",
        component: AuthLayoutComponent,
        children: [
          {
            path: "",
            loadChildren: () =>
              import("./shared/layouts/auth-layout/auth-layout.module").then(
                (m) => m.AuthLayoutModule
              ),
          },
        ],
      },
      {
        path: "",
        component: ActorLayoutComponent,
        children: [
          {
            path: "",
            loadChildren: () =>
              import("./shared/layouts/actor-layout/actor-layout.module").then(
                (m) => m.ActorLayoutModule
              ),
          },
        ],
      },
      {
        path: "",
        component: DirectorLayoutComponent,
        children: [
          {
            path: "",
            loadChildren: () =>
              import(
                "./shared/layouts/director-layouts/director-layout.module"
              ).then((m) => m.DirectorLayoutModule),
          },
        ],
      },
    ]),
    BrowserAnimationsModule,
    MatCardModule,
    MatListModule,
    MatToolbarModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
