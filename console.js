var app = angular.module('consoleApp', []);
app.controller('consoleCtrl', function($scope) {
	$scope.buffer=[];
	$scope.show=false;
	$scope.commandSet=[];
	$scope.keyup = function(event) {
        //console.log('keyup', event);
		$scope.buffer.push(event.keyCode);
		var codes = {};
		$scope.buffer.forEach(function(code) {
			codes['key_' + code] = 1;
		});
		
		//if ctrl+backquote is pressed
		if ((codes.key_17) && codes.key_192) {
			console.log("keys are pressed");
			$scope.show=true;
			document.getElementById('txtInput').focus();
			//setFocus("txtInput");
			$scope.buffer=[];
		}
		//if enter is pressed
		if (codes.key_13) 
		{
			if($scope.command !=undefined)
			{
				$scope.commandSet =$scope.command.split(' ');
				console.log("execute command",$scope.command,$scope.commandSet.length);
				$scope.buffer=[];
				$scope.executeCommand();
			}
		}
    };
	
	$scope.executeCommand=function(){
		console.log("I am in function");
		$scope.commandSet =$scope.command.split(' ');
		var commandSet=$scope.commandSet;
		if(commandSet.length==1)
		{
			var input = commandSet[0].toUpperCase().trim();
			switch(input)
			{
				case "CLS":
					console.log("clear is pressed");
					document.getElementById('divOutput').innerHTML="";
					document.getElementById('txtInput').value="";
					break;
				
				default:
					console.log("go to server");
					$scope.takeAction();
				
				
			}
		
		}
		else
			$scope.takeAction();
	}
	
	$scope.takeAction=function()
	{
		var newSpan = document.createElement('span');
		newSpan.innerText=document.getElementById('txtInput').value;
		document.getElementById('divOutput').appendChild(newSpan);
		var linebreak = document.createElement("br");
		document.getElementById('divOutput').appendChild(linebreak);
		document.getElementById('txtInput').value="";
	}
		
});

function setFocus(element)
{
	document.getElementById(element).focus();
}
function executeCommand(commandSet)
{
	console.log("I am in function");
	if(commandSet.length==1)
	{
		var input = commandSet[0].toUpperCase().trim();
		switch(input)
		{
			case "CLS":
				console.log("clear is pressed");
				document.getElementById('divOutput').innerHTML="";
				break;
				
			default:
				console.log("go to server");
				takeAction();
				
				
		}
		
	}
	else
		takeAction();
	
}

function takeAction()
{
	var newSpan = document.createElement('span');
	newSpan.innerText=document.getElementById('txtInput').value;
	document.getElementById('divOutput').appendChild(newSpan);
	var linebreak = document.createElement("br");
	document.getElementById('divOutput').appendChild(linebreak);
	document.getElementById('txtInput').value="";
}