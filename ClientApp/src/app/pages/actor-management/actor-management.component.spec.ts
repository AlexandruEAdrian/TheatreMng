import { async, ComponentFixture, TestBed } from "@angular/core/testing";

import { ActorManagementComponent } from "./actor-management.component";

describe("StudentManagementComponent", () => {
  let component: ActorManagementComponent;
  let fixture: ComponentFixture<ActorManagementComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ActorManagementComponent],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActorManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it("should create", () => {
    expect(component).toBeTruthy();
  });
});
