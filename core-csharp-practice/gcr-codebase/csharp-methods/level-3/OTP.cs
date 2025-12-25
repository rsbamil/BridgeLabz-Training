using System;

class OTPGenerator{
    public static int GenerateOTP(){
        Random r = new Random();
        int otp = r.Next(100000, 1000000);   // 6 digit OTP
        return otp;
    }

    public static bool AreOTPsUnique(int[] otps){
        for (int i = 0; i < otps.Length; i++){
            for (int j = i + 1; j < otps.Length; j++){
                if (otps[i] == otps[j]){
                    return false;
                    }
            }
        }
        return true;
    }
}

class OTP{
    static void Main(){
        int[] otps = new int[10];

        Console.WriteLine("Generated OTPs:");
        for (int i = 0; i < 10; i++){
            otps[i] = OTPGenerator.GenerateOTP();
            Console.WriteLine("OTP " + (i + 1) + " = " + otps[i]);
        }

        if (OTPGenerator.AreOTPsUnique(otps)){
            Console.WriteLine("\nAll OTPs are UNIQUE");
            }
        else{
            Console.WriteLine("\nSome OTPs are DUPLICATE");
            }
    }
}
