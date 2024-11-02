
            Console.WriteLine("دریافت رشته")
            string input = Console.ReadLine();

            List<string> validPhoneNumbers = ExtractPhoneNumbers(input);

            Console.WriteLine("شماره‌های معتبر عبارتند از:");
            foreach (string phone in validPhoneNumbers)
            {
                Console.WriteLine(phone);
            }
        }

        static List<string> ExtractPhoneNumbers(string input)
        {
            List<string> validPhoneNumbers = new List<string>();
            Regex regex = new Regex(@"0\d{9}");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string phoneNumber = match.Value;
                if (HasAtLeastTwoDifferentDigits(phoneNumber))
                {
                    validPhoneNumbers.Add(phoneNumber);
                }
            }

            return validPhoneNumbers;
        }

        static bool HasAtLeastTwoDifferentDigits(string phoneNumber)
        {
            HashSet<char> uniqueDigits = new HashSet<char>(phoneNumber);
            return uniqueDigits.Count >= 2;
