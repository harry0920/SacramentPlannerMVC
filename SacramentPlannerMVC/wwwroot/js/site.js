// Write your JavaScript code.

var count = 0;
function Add_Speaker()
{
    
    count++;
    var label, textbox;
    label = document.createElement('label');
    label.appendChild(document.createTextNode('Enter Speaker:'));
    textbox = document.createElement('input');
    textbox.type = 'text';
    textbox.id = 'speaker' + count;
    label.appendChild(textbox);
    document.getElementById('add_speaker').appendChild(label);
}