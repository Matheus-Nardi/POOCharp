using System.Diagnostics.Tracing;

namespace Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var room = new Room(3);
            room.RoomSoldOutEvent += OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }
        
        static void OnRoomSoldOut(object sender , EventArgs e)
        {
            Console.WriteLine("Sala cheia !");
        }

    }

    public class Room
    {
        public Room(int seats ) 
        {
            Seats = seats;
        }

        public int Seats { get; set; }
        private int SeatsInUse = 0;

        public void ReserveSeat()
        {
            SeatsInUse++;
            if(SeatsInUse >= Seats ) 
            {
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento reservado");
            }

        }
     //Declaração de um evento
     public event EventHandler RoomSoldOutEvent;
     protected virtual void OnRoomSoldOut(EventArgs e )
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this , e  );
        }
    }
}