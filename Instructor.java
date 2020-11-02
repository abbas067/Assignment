import java.util.*;
class Instructor{

public static void main(String [] args){
		      Queue q = new LinkedList<>();
	String fname,lname;
	int no_of_course;
Scanner sc=new Scanner(System.in);
System.out.println("Enter details of instrucor");	
for(int i=1;i<=5;i++)
{
	System.out.println("Enter first name of " +i+" th instrucor");	
	fname=sc.next();
	q.add(fname);
	System.out.println("Enter last name of " +i+" th instrucor");	
	lname=sc.next();
	q.add(lname);
		System.out.println("Enter number of courses teach by " +i+" th instrucor");	
	no_of_course=sc.nextInt();
	q.add(no_of_course);
}
System.out.println(q);
}
}