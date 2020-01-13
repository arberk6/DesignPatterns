import React from "react";
// nodejs library that concatenates classes
import classNames from "classnames";
// react plugin used to create charts
import { Line, Bar } from "react-chartjs-2";

// reactstrap components
import {
  Button,
  ButtonGroup,
  Card,
  CardHeader,
  CardBody,
  CardTitle,
  DropdownToggle,
  DropdownMenu,
  DropdownItem,
  UncontrolledDropdown,
  Label,
  FormGroup,
  Input,
  Table,
  Row,
  Col,
  Dropdown,
  dropdownOpen,
  UncontrolledTooltip
} from "reactstrap";

import "../assets/css/app.css";
import FirstClass from "../services/FirstClass.js";

export class AddPerson extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      data: {
        type: "type",
        Name: "",
        LastName: "",
        Age: ""
      }
    };
  }

  UpdateData = e => {
    var name = e.target.name;
    var val = e.target.value;

    this.setState({
      data: {
        ...this.state.data,
        [name]: val
      }
    });
  };

  service = new FirstClass();

  submit = e => {
    e.preventDefault();

    //this.service.
  };

  handleOnChange = e => {
    var name = e.target.name;
    var val = e.target.value;
    this.setState({
      data: {
        ...this.state.data,
        [e.target.name]: e.target.value
      }
    });
  };

  render() {
    return (
      <>
        <div className="content">
          <Row>
            <Col className="col-sm-6">
              <Card className="card-chart that">
                <CardHeader>
                  <h2>Please add a Person and define the type</h2>
                </CardHeader>
                <CardBody>
                  <Row className="ml-2 d-flex justify-content-around text-center">
                    <FormGroup>
                      <Label>First Name</Label>
                      <Input
                        defaultValue=""
                        name="Name"
                        onChange={e => this.handleOnChange(e)}
                        placeholder="Name"
                        type="text"
                      />
                    </FormGroup>
                  </Row>
                  <Row className="ml-2 d-flex justify-content-around text-center">
                    <FormGroup>
                      <Label>Last Name</Label>
                      <Input
                        defaultValue=""
                        name="LastName"
                        placeholder="LastName"
                        onChange={e => this.handleOnChange(e)}
                        type="text"
                      />
                    </FormGroup>
                  </Row>
                  <Row className="ml-2 d-flex justify-content-around text-center">
                    <FormGroup>
                      <Label>Age</Label>
                      <Input
                        defaultValue=""
                        name="Age"
                        placeholder="Age"
                        onChange={e => this.handleOnChange(e)}
                        type="number"
                      />
                    </FormGroup>
                  </Row>
                  <Row className="ml-2 text-center d-flex justify-content-center">
                    <UncontrolledDropdown group className="h-50 ml-1 mt-4">
                      <DropdownToggle caret color="primary" className="m-0">
                        {this.state.data.type}
                      </DropdownToggle>
                      <DropdownMenu>
                        <DropdownItem
                          type="text"
                          key={1}
                          value="Student"
                          name="type"
                          onClick={e => this.UpdateData(e)}
                        >
                          Student
                        </DropdownItem>

                        <DropdownItem
                          type="text"
                          key={2}
                          value="Profesor"
                          name="type"
                          onClick={e => this.UpdateData(e)}
                        >
                          Profesor
                        </DropdownItem>
                      </DropdownMenu>
                    </UncontrolledDropdown>
                  </Row>
                  <Row className="d-flex justify-content-around mt-3">
                    <Col className="col-sm-4 d-flex justify-content-around">
                      <Button color="success" onClick={e => this.submit(e)}>
                        Submit
                      </Button>
                    </Col>
                  </Row>
                </CardBody>
              </Card>
            </Col>
          </Row>
        </div>
      </>
    );
  }
}
export default AddPerson;
