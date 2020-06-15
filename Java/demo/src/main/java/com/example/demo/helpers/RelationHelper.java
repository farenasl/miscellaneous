package com.example.demo.helpers;

import java.util.concurrent.ExecutionException;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;
import java.util.stream.Collectors;

import com.example.demo.dto.Relation;
import com.example.demo.dto.RequestDTO;

public class RelationHelper {
    public static boolean validateRelations(final RequestDTO request) throws InterruptedException, ExecutionException {
        return validatePercentages(request);
    }

    private static boolean validatePercentages(final RequestDTO request)
            throws InterruptedException, ExecutionException {
        // Executors.newFixedThreadPool(3) --- in parallel execution
        // Executors.newSingleThreadExecutor -- in sequential execution

        final ParallelizerHelper p = new ParallelizerHelper(Executors.newFixedThreadPool(3));

        final Future<Boolean> a = p.allGreaterThan2Percent(request.getArt85().getDC().getChange().stream()
            .map(Relation::getPorcentaje).collect(Collectors.toList()));
        final Future<Boolean> b = p.allGreaterThan10Percent(request.getArt85().getCD().getChange().stream()
            .map(Relation::getPorcentaje).collect(Collectors.toList()));
        final Future<Boolean> c = p.totalIsLessThan100Percent(request.getArt85().getSP().getChange().stream()
            .map(Relation::getPorcentaje).collect(Collectors.toList()));

        while (!a.isDone() || !b.isDone() || !c.isDone()) {
            System.out.println(String.format("Task 1 is %s, Task 2 is %s and Task 3 is %s."
                , a.isDone() ? "done" : "not done"
                , b.isDone() ? "done" : "not done"
                , c.isDone() ? "done" : "not done"));

            Thread.sleep(300);
        }

        return a.get() && b.get() && c.get();
    }    
}