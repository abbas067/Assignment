import java.util.*;
class Add{
public static void addNumber(double toReach)
{
	double sum=0.0,num=0.0;
	Scanner sc=new Scanner(System.in);
	try{
		while(sum<toReach){

	System.out.println("Please enter positive decimal number");
	num=sc.nextDouble();
	sum=sum+num;
	System.out.println("Current value of the sum is:"+sum);
	}
}
catch(InputMismatchException e)
{
	System.out.println("You input is not a decimal number");	
}
}
public static void main(String [] args)
{
	addNumber(10.0);
}	
}