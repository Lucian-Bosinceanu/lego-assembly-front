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

export class BackTable extends React.Component {

    constructor(props) {
        super(props);

        this.state = {
            rows: []
        }
    }

    componentDidMount() {
        const data = [
            this.createData("Gestionarea Input-Ouput", "Se ocupă cu importarea modelelor 3D și cu exportarea sculpturilor lego în format json rezultate în urma prelucrării modelelor.", "Băcăoanu Camelia & Amariei Oana (B4)"),
            this.createData("Validarea input-ului", "Are ca scop validarea faptului că fișierul json primit ca input respectă specificațiile unui model 3D rezultat în urma exportării acestuia de pe front.", "Feciuc Stelian & Bojescu Mihai (lider echipă)"),
            this.createData("Îmbinarea cuburilor", "Algoritm care are ca scop îmbinarea cuburilor modelului 3D cu scopul de a obține piese lego cu dimensiuni specificate apriori.", "Cojocaru Dragoș & Tîrpescu Andrei"),
            this.createData("Construcția grafului", "Pe baza structurii de piese lego rezultate în urma îmbinării, se construiește un graf în care nodurile sunt piese, iar muchiile sunt conexiunile dintre ele.", "Crivoi Andrei"),
            this.createData("Validarea grafului", "Se testează ca graful să nu aibă vulnerabilități structurale cu scopul validării întregii construcții.", "Cășuneanu Andrei & Timofte Andrei"),
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
