var Drill = React.createClass({
    render: function() {
        return (<tr><td>{this.props.boob}</td>
                    <td>xxx</td>
                    <td>xxx</td>
                    <td>xxx</td>
                    <td>xxx</td>
                    <td>xxx</td>
                </tr>
      );
    }
});

var DrillList = React.createClass({
    render: function() {
    var commentNodes = this.props.data.map(function(comment) {
      return (
        <Drill boob={comment.Name}></Drill>
      );
    });
    return (
      <tbody>{commentNodes}
      </tbody>
    );
  }
});


var DrillTable = React.createClass(
{
    loadCommentsFromServer: function () {
        console.log('loadCommentsFromServer');
        var xhr = new XMLHttpRequest();
        xhr.open('get', this.props.url, true);
        xhr.onload = function () {
            var data = JSON.parse(xhr.responseText);
            this.setState({ data: data });
        }.bind(this);
        xhr.send();
    },
    getInitialState: function () {
        console.log('getInitialState');
        return { data: [] };
    },
    componentDidMount: function () {
        console.log('componentDidMount');
        this.loadCommentsFromServer();
        window.setInterval(this.loadCommentsFromServer, this.props.pollInterval);
    },
    render: function() {
        return(
             <table className="table">
                        <thead>
                            <tr>
                                <td>Name</td>
                                <td>Start Position</td>
                                <td>Procedure</td>
                                <td>Suggested TimeSpan</td>
                                <td>Suggested Reps</td>
                                <td>Target Par</td>
                            </tr>
                        </thead>
                        
                            <DrillList data={this.state.data} />
                           
                        
                    </table>
        );
    }
});

ReactDOM.render(
  <DrillTable url="http://localhost:12441/api/drills" pollInterval={2000} />,
  document.getElementById('drillTable')
);