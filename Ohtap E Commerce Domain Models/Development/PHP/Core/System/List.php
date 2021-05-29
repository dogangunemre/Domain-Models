<?php
namespace Ohtap\ECommerce\DomainModels\Core\System;

/*
 * https://medium.com/@moinuddinchowdhury/serialize-vs-json-67fe872a7755
 * https://www.php.net/manual/tr/class.ds-collection.php
 *https://stackoverflow.com/questions/59905261/how-do-you-properly-clear-a-json-encode-error-state
 */

class Lista extends \ArrayObject implements \IteratorAggregate, \JsonSerializable  {
    public $innerList;

    public function __construct($input = array(), $flags = 0, $iterator_class = "ArrayIterator")
    {
        parent::__construct($input, $flags, $iterator_class);
        $this->innerList = array();
    }

    public function Count(){
        return count($this->innerList);
    }
    public function Add($item){
        $this->innerList[] = $item;
    }
    public function Insert($index, $item){
        $this->innerList[$index] = $item;
    }
    public function Clear(){
        unset($this->innerList);
    }
    public function IndexOf($item){
        return array_search($this->innerList, $item);
    }
    public function Remove($item){
        $index =  $this->IndexOf($item);
        unset($this->innerList[$index]);
    }
    public function RemoveAt($index, $item){
        unset($this->innerList[$index]);
    }


    public function __get($name)
    {
        return $this->innerList[$name];
    }
    public function __set($name, $value)
    {
        return $this->innerList[$name] = $value;
    }
    public function __isset($name)
    {
        return isset($this->innerList);
    }
    public function __unset($name)
    {
        unset($this->innerList);
    }


    public function getIterator() {
        return new \ArrayIterator($this->innerList);
    }

    public function toArray() : array {
        return $this->innerList;
    }


    public function offsetSet($index, $newval)
    {
//        if (!is_int($newval)) {
//            throw new \InvalidArgumentException("Must be int");
//        }

        parent::offsetSet($index, $newval);
    }

    public function jsonSerialize()
    {
        return $this->innerList;
    }
}
