use Data::Dumper;
 #cerner_2^5_2022
my @array= qw(1 2 3 4 5 6 8 9 2 5);
 
my $highest=@array[0];
 
foreach my $number (@array) {
    if (@array[$number] > $highest) {
    $highest = @array[$number];
    }
}
print Dumper $highest;