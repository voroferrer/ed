package serpis.ed.asuma;

import android.os.Build;
import android.support.annotation.RequiresApi;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.util.Log;
import android.widget.EditText;
import android.widget.TextView;

import java.math.BigDecimal;
import java.util.function.BinaryOperator;

public class MainActivity extends AppCompatActivity {

    private static final String TAG = MainActivity.class.getSimpleName();

    private EditText editText1;
    private EditText editText2;
    private TextView textViewResult;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void buttonAddOnClick(View View){
        operation(BigDecimal::add);
    }
    public void buttonSubtractOnClick(View View){
        operation(BigDecimal::subtract);
    }
    private BigDecimal getNumber1(){
        return new BigDecimal(editText1.getText().toString());
    }
    private BigDecimal getNumber2(){
        return new BigDecimal(editText2.getText().toString());
    }
    private void operation(BinaryOperator<BigDecimal> binaryOperator){
        Log.i(TAG, "buttonAddOnClick");
        BigDecimal number1 = getNumber1();
        BigDecimal number2 = getNumber2();
        BigDecimal result = binaryOperator.apply(number1,number2);
        textViewResult.setText(result.toString());
    }
}
