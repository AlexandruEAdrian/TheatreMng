import { async, ComponentFixture, TestBed } from "@angular/core/testing";

import { DirectorManagementComponent } from "./director-management.component";

describe("DirectorManagementComponent", () => {
  let component: DirectorManagementComponent;
  let fixture: ComponentFixture<DirectorManagementComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [DirectorManagementComponent],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DirectorManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it("should create", () => {
    expect(component).toBeTruthy();
  });
});
