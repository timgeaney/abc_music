


public class Beep {
	
	public static double[] beep(double frequency, double duration)
	{
		int N = (int)(StdAudio.SAMPLE_RATE*duration);
		double[] a = new double[N + 1];
		for(int i = 0; i < N; i++)
		{
			a[i] = Math.sin(2 * Math.PI*i*frequency/ StdAudio.SAMPLE_RATE);
		}
		return a;
	
	}
	
	
	
	
}
