import java.util.*;  
class LinkedList {
	 Node head; 
      class Node { 
        int data; 
        Node next; 
        Node(int d) 
        { 
            data = d; 
            next = null; 
        } 
    } 
	public void insertFront(int num) 
    { 
        Node new_node = new Node(num); 
        new_node.next = head; 
          head = new_node; 
    } 
	public void insertBack(int num) 
    { 
       
	   Node new_node = new Node(num); 
	   if (head == null) 
    { 
        head = new Node(num); 
        return; 
    } 
  
    new_node.next = null; 
      Node last = head;  
    while (last.next != null) 
        last = last.next; 
      last.next = new_node; 
    return; 
    } 
    public int count() 
    { 
        Node current = head; 
        int count = 0; 
        while (current != null) { 
                count++; 
            current = current.next; 
        } 
        return count; 
    } 
	public int sum() {
		Node cur=head;
    int sum = 0;
    while (cur!= null) {
        sum += cur.data;
        cur= cur.next;
    }
    return sum;
}
	public void display() 
    { 
        Node current = head; 
        if(current==null)
		   System.out.println("list is empty");	
	   else{
	   		   System.out.println("elements of list:");	
        while (current != null) { 
              System.out.print(current.data+" ");
            current = current.next; 
        } 
		              System.out.print("\n");
	   }
    } 

    public static void main(String args[])  
    {  
	    Scanner sc=new Scanner(System.in);
                LinkedList list = new LinkedList();  
		while(true)
		{
			System.out.println("1.Insert At Front");
			System.out.println("2.Insert At Back");
			System.out.println("3.Display list ");
			System.out.println("4.Count element of list");
			System.out.println("5.Sum elements of list");
			System.out.println("6.Exit");

	int choice;
	System.out.println("Enter your choice");
	choice=sc.nextInt();
	switch(choice){
			case 1: System.out.println("Enter the element to push");
			    int n=sc.nextInt();
			list.insertFront(n); 
			break;
			case 2:System.out.println("Enter the element to push");
			    int n1=sc.nextInt();
			list.insertBack(n1);
			break;
			case 3: list.display();
			break;
			case 4: System.out.print("number of items in the list:"+list.count()+"\n");
			break;
			case 5:System.out.print("sum of items in the list:"+list.sum()+"\n");
			break;
			case 6: System.out.println("Exiting the application");
			System.exit(0);
			default: System.out.println("Incorrect input!!! Please re-enter choice from our menu");
			}

		}	
    
    }  
} 

