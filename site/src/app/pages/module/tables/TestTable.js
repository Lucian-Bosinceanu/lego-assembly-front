import React from "react";
import Table from "@material-ui/core/Table"
import { TableRow, TableHead, TableBody, TableCell } from "@material-ui/core";
import { withStyles } from '@material-ui/core/styles';

const CustomTableCell = withStyles(theme => ({
    head: {
      backgroundColor: theme.palette.common.black,
      color: theme.palette.common.white,
    },
    body: {
      fontSize: 14,
    },
  }))(TableCell);

export class TestTable extends React.Component {

    constructor(props) {
        super(props);

        this.state = {
            rows: []
        }
    }

    componentDidMount() {
        const data = [
            this.createData("Testare negativă", "Testarea și alcătuirea de rapoarte pentru scenarii negative, atât pe componente, cât și pe integrări.", "Apușcășiței Silviu (lider echipă)"),
            this.createData("Testare de performanță", "Idem, dar pentru testarea performanței aplicației.", "Anton Cătălin"),
            this.createData("Testare pozitivă", "Idem, dar pentru scenarii pozitive.", "Dima Ionuț"),
            this.createData("Testare de complexitate", "Idem, dar pentru scenarii cu situații complexe.", "Tincu Gabriel"),
        ]

        this.setState({
            id: this.state.id,
            rows: data
        })
    }

    createData(module, description, members) {
        return {module, description, members}
    }

  render() {
    return (
            <Table>
                <TableHead>
                    <TableRow>
                        <CustomTableCell>Nume submodul</CustomTableCell>
                        <CustomTableCell>Scurtă descriere</CustomTableCell>
                        <CustomTableCell>Membri</CustomTableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {
                        this.state.rows.map( (row, rowId = 0) => {
                            return (
                                <TableRow key={rowId++}>
                                    <TableCell>{row.module}</TableCell>
                                    <TableCell>{row.description}</TableCell>
                                    <TableCell>{row.members}</TableCell>
                                </TableRow>
                            )
                        })
                    }
                </TableBody>
            </Table>
    );
  }
}
