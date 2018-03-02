package com.example.myfirstapp;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;


public class DisplayMessageActivity extends AppCompatActivity {
    private static final String TAG= DisplayMessageActivity.class.getSimpleName();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_display_message);
        String message = getIntent().getStringExtra(MainActivity.MESSAGE_KEY);
        Log.i(TAG,message);
        TextView textView = findViewById(R.id.editText);


    }
}
