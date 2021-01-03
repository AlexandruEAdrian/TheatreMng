import { async, ComponentFixture, TestBed } from "@angular/core/testing";
import { DirectorLayoutComponent } from "./director-layout.component";

describe("DirectorLayoutComponent", () => {
  let component: DirectorLayoutComponent;
  let fixture: ComponentFixture<DirectorLayoutComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [DirectorLayoutComponent],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DirectorLayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it("should create", () => {
    expect(component).toBeTruthy();
  });
});
