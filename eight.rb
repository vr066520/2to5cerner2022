arr = [12,45,23,33,38];
#cerner_2^5_2022
count = 0;
large = 0;

large=arr[0];

while (count<arr.size)
    if(large<arr[count])
        large=arr[count];
    end
    count=count + 1;
end

print "Largest element is: ",large,"\n";