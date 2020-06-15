package com.example.demo.helpers;

import java.util.List;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Future;
import java.util.stream.Collectors;

public class ParallelizerHelper {
    private final ExecutorService executor;

    ParallelizerHelper(ExecutorService executor) {
        this.executor = executor;
    }

    Future<Boolean> allGreaterThan2Percent(List<String> percentages) {
        return executor.submit(() -> {
            Thread.sleep(10000);
            return percentages.stream()
                .filter(x -> Double.valueOf(x) < 2)
                .collect(Collectors.toList()).size() == 0 ? true : false;
        });
    }

    Future<Boolean> allGreaterThan10Percent(List<String> percentages) {
        return executor.submit(() -> {
            Thread.sleep(10000);
            return percentages.stream()
                .filter(x -> Double.valueOf(x) < 10)
                .collect(Collectors.toList()).size() == 0 ? true : false;
        });
    }

    Future<Boolean> totalIsLessThan100Percent(List<String> percentages) {
        return executor.submit(() -> {
            Thread.sleep(10000);
            return getSum(percentages) <= 100 ? true : false;
        });
    }

    private static Double getSum(List<String> numbers) {
        Double sum = 0.0;
          
        for(int i = 0;i < numbers.size(); i++) {
           sum += Double.valueOf(numbers.get(i));
        }
        return sum;
     }
}
