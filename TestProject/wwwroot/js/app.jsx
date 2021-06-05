class User extends React.Component {
    constructor(props) {
        super(props);

        this.onDateRegistrationChange = this.onDateRegistrationChange.bind(this);
        this.onDateLastActivityChange = this.onDateLastActivityChange.bind(this);
    }

    onDateRegistrationChange(e) {
        e.preventDefault();

        this.props.onRegistrationChange(this.props.Id, e.target.value);
    }

    onDateLastActivityChange(e) {
        e.preventDefault();

        this.props.onLastActivityChange(this.props.Id, e.target.value);
    }

    render() {
        return <React.Fragment>
            <tr>
                <td>
                    <input type="number" className="form-control" readOnly value={this.props.Id} />
                </td>
                <td>
                    <input type="date" className="form-control" value={this.props.RegistrationDate} onChange={this.onDateRegistrationChange} />
                </td>
                <td>
                    <input type="date" className="form-control" value={this.props.LastActivityDate} onChange={this.onDateLastActivityChange} />
                </td>
            </tr>
        </React.Fragment>
    }
}

class UserForm extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            users: [
                {
                    Id: 1,
                    RegistrationDate: "2021-06-01",
                    LastActivityDate: "2021-06-01"
                },
                {
                    Id: 2,
                    RegistrationDate: "2021-06-01",
                    LastActivityDate: "2021-06-01"
                },
                {
                    Id: 3,
                    RegistrationDate: "2021-06-01",
                    LastActivityDate: "2021-06-01"
                },
                {
                    Id: 4,
                    RegistrationDate: "2021-06-01",
                    LastActivityDate: "2021-06-01"
                },
                {
                    Id: 5,
                    RegistrationDate: "2021-06-01",
                    LastActivityDate: "2021-06-01"
                }
            ]
        };

        this.onRegistrationDateChange = this.onRegistrationDateChange.bind(this);
        this.onLastActivityDateChange = this.onLastActivityDateChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    onRegistrationDateChange(key, value) {
        var newUsers = this.state.users;
        newUsers[key - 1].RegistrationDate = value;
        this.setState({users: newUsers});
    }

    onLastActivityDateChange(key, value) {
        var newUsers = this.state.users;
        newUsers[key - 1].LastActivityDate = value;
        this.setState({ users: newUsers });
    }

    handleSubmit(e) {
        e.preventDefault();

        console.log(this.state.users);

        if (this.state.users)
        {
            fetch('/api/Users', {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify(this.state.users)
            });
        }
    }

    render() {
        return <React.Fragment>
            <form onSubmit={this.handleSubmit}>
                <table className="table">
                    <thead className="thead-dark">
                        <tr>
                            <th scope="col">UserId</th>
                            <th scope="col">Date Registration</th>
                            <th scope="col">Date Last Activity</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            this.state.users.map((user) =>
                                <User key={user.Id}
                                    Id={user.Id}
                                    RegistrationDate={user.RegistrationDate}
                                    LastActivityDate={user.LastActivityDate}
                                    onRegistrationChange={this.onRegistrationDateChange}
                                    onLastActivityChange={this.onLastActivityDateChange}
                                />
                            )
                        }
                    </tbody>
                </table>

                <button className="btn btn-primary" type="submit">Save</button>
            </form>
        </React.Fragment>
    }
}

class Diagram extends React.Component {
    constructor(props) {
        super(props);

        this.onCalculate = this.onCalculate.bind(this);
    }

    onCalculate() {
        fetch('/api/Users', {
            method: 'GET',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
            }
        })
            .then(responce => responce.json())
            .then(newData => console.log(newData));
    }

    render() {
        return <React.Fragment>
            <button className="btn btn-primary" onClick={this.onCalculate}>Calculate</button>
        </React.Fragment>
    }
}

class App extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return <React.Fragment>
            <UserForm />
            <Diagram />
        </React.Fragment>
    }
}

ReactDOM.render(
    <App />,
    document.getElementById("app")
);