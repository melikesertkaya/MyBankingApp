## Test Metodları

BankAccount sınıfı için yazılan testler, sınıfın doğru çalıştığını doğrulamak amacıyla yazılmıştır. Aşağıda, bu testlerin bazıları ve ne yaptıkları açıklanmaktadır:

- `Deposit_WithPositiveAmount_UpdatesBalance`: Pozitif bir miktar yatırıldığında bakiyenin güncellenip güncellenmediğini kontrol eder.
- `Deposit_WithNegativeAmount_ThrowsArgumentException`: Negatif bir miktar yatırılmaya çalışıldığında bir `ArgumentException` fırlatılıp fırlatılmadığını kontrol eder.
- `Withdraw_WithSufficientFunds_UpdatesBalance`: Yeterli bakiye olduğunda para çekme işleminin doğru şekilde gerçekleştirilip gerçekleştirilmediğini kontrol eder.
- `Withdraw_WithInsufficientFunds_ThrowsInvalidOperationException`: Yetersiz bakiye olduğunda para çekme işleminin `InvalidOperationException` fırlatıp fırlatmadığını kontrol eder.
- `Transfer_ValidTransaction_UpdatesBothAccounts`: Geçerli bir para transferi işleminin hem kaynak hem de hedef hesapların bakiyelerini doğru şekilde güncelleyip güncelleyemediğini kontrol eder.
- `Transfer_WithInsufficientFunds_ThrowsInvalidOperationException`: Yetersiz bakiye olduğunda para transferi işleminin `InvalidOperationException` fırlatıp fırlatmadığını kontrol eder.
- `GetTransactionHistory_ReturnsCorrectHistory`: İşlem geçmişinin doğru bir şekilde kaydedilip kaydedilmediğini kontrol eder.
