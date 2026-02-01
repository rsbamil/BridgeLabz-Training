using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Future_Logistics
{
    public abstract class GoodsTransport
    {
        protected string transportId;
        protected string transportDate;
        protected int transportRating;

        public string TransportId
        {
            get { return transportId; }
            set { transportId = value; }
        }

        public string TransportDate
        {
            get { return transportDate; }
            set { transportDate = value; }
        }

        public int TransportRating
        {
            get { return transportRating; }
            set { transportRating = value; }
        }

        public GoodsTransport(string transportId, string transportDate, int transportRating)
        {
            this.transportId = transportId;
            this.transportDate = transportDate;
            this.transportRating = transportRating;
        }

        public abstract string vehicleSelection();
        public abstract float calculateTotalCharge();
    }
    public class BrickTransport : GoodsTransport
    {
        private float brickSize;
        private int brickQuantity;
        private float brickPrice;

        public float BrickSize
        {
            get { return brickSize; }
            set { brickSize = value; }
        }

        public int BrickQuantity
        {
            get { return brickQuantity; }
            set { brickQuantity = value; }
        }

        public float BrickPrice
        {
            get { return brickPrice; }
            set { brickPrice = value; }
        }

        public BrickTransport(string transportId, string transportDate, int transportRating,
                              float brickSize, int brickQuantity, float brickPrice)
            : base(transportId, transportDate, transportRating)
        {
            this.brickSize = brickSize;
            this.brickQuantity = brickQuantity;
            this.brickPrice = brickPrice;
        }

        public override string vehicleSelection()
        {
            if (brickQuantity < 300)
                return "Truck";
            else if (brickQuantity <= 500)
                return "Lorry";
            else
                return "MonsterLorry";
        }

        public override float calculateTotalCharge()
        {
            float price = brickPrice * brickQuantity;
            float tax = price * 0.30f;

            float discount = 0;
            if (transportRating == 5)
                discount = price * 0.20f;
            else if (transportRating == 3 || transportRating == 4)
                discount = price * 0.10f;

            float vehiclePrice = vehicleSelection().ToLower() switch
            {
                "truck" => 1000,
                "lorry" => 1700,
                _ => 3000
            };

            return (price + vehiclePrice + tax) - discount;
        }
    }
    public class TimberTransport : GoodsTransport
    {
        private float timberLength;
        private float timberRadius;
        private string timberType;
        private float timberPrice;

        public TimberTransport(string transportId, string transportDate, int transportRating,
                               float timberLength, float timberRadius, string timberType, float timberPrice)
            : base(transportId, transportDate, transportRating)
        {
            this.timberLength = timberLength;
            this.timberRadius = timberRadius;
            this.timberType = timberType;
            this.timberPrice = timberPrice;
        }

        public override string vehicleSelection()
        {
            float area = 2 * 3.147f * timberRadius * timberLength;

            if (area < 250)
                return "Truck";
            else if (area <= 400)
                return "Lorry";
            else
                return "MonsterLorry";
        }

        public override float calculateTotalCharge()
        {
            float volume = 3.147f * timberRadius * timberRadius * timberLength;

            float rate = timberType.Equals("Premium", StringComparison.OrdinalIgnoreCase) ? 0.25f : 0.15f;
            float price = volume * timberPrice * rate;
            float tax = price * 0.30f;

            float discount = 0;
            if (transportRating == 5)
                discount = price * 0.20f;
            else if (transportRating == 3 || transportRating == 4)
                discount = price * 0.10f;

            float vehiclePrice = vehicleSelection().ToLower() switch
            {
                "truck" => 1000,
                "lorry" => 1700,
                _ => 3000
            };

            return (price + vehiclePrice + tax) - discount;
        }
    }


}
