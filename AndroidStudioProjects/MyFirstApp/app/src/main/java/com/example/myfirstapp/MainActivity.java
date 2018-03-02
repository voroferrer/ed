package com.example.myfirstapp;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.util.Log;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {
    private static final String TAG = MainActivity.class.getSimpleName();
    public static final String MESSAGE_KEY ="MESSAGE KEY";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Log.i(TAG,"onCreate end");
    }
    public void sendMessage(View view){
        Log.i(TAG,"Dentro de SendMessage");
        EditText editText =findViewById(R.id.editText);



        Intent intent = new Intent(this, DisplayMessageActivity.class);
        intent.putExtra(MESSAGE_KEY,editText.getText().toString());
        startActivity(intent);

    }

}
