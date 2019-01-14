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

export class FrontTable extends React.Component {

    constructor(props) {
        super(props);

        this.state = {
            rows: []
        }
    }

    componentDidMount() {
        const data = [
            this.createData("Crearea cuburilor", "Funcționalitatea de bază cu ajutorul căreia se realizează modelul 3D pornind de la manipularea drag&drop a unui cub de origine.", "Stan Mihai & Stan Radu"),
            this.createData("Ștergerea cuburilor", "Permite ștergerea cuburilor create.", "Crăiniceanu Cătălin"),
            this.createData("Gestionarea camerei", "Cu ajutorul mouse-ului se poate manipula camera pentru a facilita realizaea modelului 3D.", "Cojocaru Ștefan"),
            this.createData("Interfața", "O bară cu meniuri și butoane care facilitează operațiile IO, modelarea 3D și vizualizarea sculpturii lego.", "Ivan Monica (lider echipă)"),
            this.createData("Validarea construcției", "Ansamblu de metode care se asigură ca modelul 3D nu are discontinuități. Colorează cuburile valide cu verde și cele discontinue cu roșu.", "Morcoteț Marian"),
            this.createData("Gestionarea Input-Ouput", "Asigură exportarea modelului 3D în format json, dar și importarea sculpturii lego rezultate în urma prelucrării modelului 3D de către aplicația back-end.", "Gînju Cristian"),
            this.createData("Prezentarea solutiei", "Funcționalitate care permite vizualizarea construcției sculpturii lego prin intermediul unei interfețe similare unui player video.", "Martoncă Rafael"),
            this.createData("Aspectul pieselor lego", "Realizarea de modele 3D și texturile corespunzătoare pieselor uzual folosite în construcția sculpturilor lego: 1x1, 1x2, 2x2, 1x3 etc.", "Cobzac Șerban"),
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
