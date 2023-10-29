using Godot;


public partial class Maze_evaluation : Node2D
{


	public int[,] cornMaze = {
			{'w','w','w','w','w','w','w','w'},
			{'w','w','w','w','w','w','w','w'},
			{'w','w','w','w','w','w','w','w'},
			{'w','w','w','w','w','w','w','w'},
			{'w','w','w','w','w','w','w','w'},
			{'w','w','w','w','w','w','w','w'},
			{'w','w','w','w','w','w','w','w'},
			{'w','w','w','w','w','w','w','w'}
		};
		
	private int _score;
	
	public void StartEvaluation()
	{

//		cornMaze = {
//			{'w','w','w','w','w','w','w','w'},
//			{'w','w','w','w','w','w','w','w'},
//			{'w','w','w','w','w','w','w','w'},
//			{'w','w','w','w','w','w','w','w'},
//			{'w','w','w','w','w','w','w','w'},
//			{'w','w','w','w','w','w','w','w'},
//			{'w','w','w','w','w','w','w','w'},
//			{'w','w','w','w','w','w','w','w'}
//		};
		

		var message = GetNode<Label>("showingText");
		
		string boardText = "";
		
		for (int i = 0; i < 8; i++) 
		{
			for (int j = 0; j <  8; j++) 
			{
				cornMaze[i,j] = 'a';
				boardText += 'd';
				boardText += cornMaze[i,j];
			}
			boardText += "\n";
			
		}
		
		message.Text = boardText;
		message.Show();
		
	}
	
	public override void _Ready()
	{
		StartEvaluation();
	}

}
