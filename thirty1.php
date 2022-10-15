<?php
namespace RefactoringGuru\Singleton\Conceptual;
class Singleton
{//cerner_2^5_2022
    private static $instances = [];
    protected function __construct() { }
    protected function __clone() { }
        public static function getInstance(): Singleton
    {
        $cls = static::class;
        if (!isset(self::$instances[$cls])) {
            self::$instances[$cls] = new static();
        }
        return self::$instances[$cls];
    }
    public function someBusinessLogic()
    {
        // ...
    }
}
function clientCode()
{
    $s1 = Singleton::getInstance();
    $s2 = Singleton::getInstance();
    if ($s1 === $s2) {
        echo "Singleton works, both variables contain the same instance.";
    } else {
        echo "Singleton failed, variables contain different instances.";
    }
}
clientCode();