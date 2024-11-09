import xunit

public class MarsRoverKataTests(){

// You are given the initial starting point (x,y) of a rover and the direction (N,S,E,W) it is facing.
// The rover receives a character array of commands.
// Implement commands that move the rover forward/backward (f,b).
// Implement commands that turn the rover left/right (l,r).

// Start @ 0,0 
// Facing X direction 
// Can move forward/backward
// Can pivot left/right

    [Fact] 
    public async void OnStart_GetPosition_ShouldBe_0_0_North() {
        var sut = new MarsRoverKata();

        var result = await sut.GetPosition();

        result.Should().Be([0,0]);
    }


}