using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Repo

    {
        private IConsole _console;
        public void ProgramUI(IConsole console) { _console = console; }
        string linebreak = "\n";
        public string Hangman0 ()
        {
            
            return $" ************************    {linebreak}         HANGMAN           {linebreak}************************    {linebreak}________ {linebreak}|  | {linebreak}| ( ) {linebreak}| /|\\ {linebreak}|  | {linebreak}| / \\   {linebreak}| {linebreak}| {linebreak}|_______ ";
        }
        public string Hangman1()
        {
                
            return $" ************************    {linebreak}         HANGMAN           {linebreak}************************    {linebreak}________ {linebreak}|  | {linebreak}| ( ) {linebreak}| /|\\ {linebreak}|  | {linebreak}| /    {linebreak}| {linebreak}| {linebreak}|_______ ";
        }
        public string Hangman2()
            {
            return $" ************************    {linebreak}         HANGMAN           {linebreak}************************    {linebreak}________ {linebreak}|  | {linebreak}| ( ) {linebreak}| /|\\ {linebreak}|  | {linebreak}|     {linebreak}| {linebreak}| {linebreak}|_______ ";
        }
        public string Hangman3()
            {
            return $" ************************    {linebreak}         HANGMAN           {linebreak}************************    {linebreak}________ {linebreak}|  | {linebreak}| ( ) {linebreak}| /| {linebreak}|  | {linebreak}|     {linebreak}| {linebreak}| {linebreak}|_______ ";

        }
        public string Hangman4()
            {
               
            return $" ************************    {linebreak}         HANGMAN           {linebreak}************************    {linebreak}________ {linebreak}|  | {linebreak}| ( ) {linebreak}|  | {linebreak}|  | {linebreak}|     {linebreak}| {linebreak}| {linebreak}|_______ ";
        }
        public string Hangman5()
            {
                
            return $" ************************    {linebreak}         HANGMAN           {linebreak}************************    {linebreak}________ {linebreak}|  | {linebreak}| ( ) {linebreak}|   {linebreak}|   {linebreak}|     {linebreak}| {linebreak}| {linebreak}|_______ ";
        }
        public string Hangman6()
            {
            
            return $" ************************    {linebreak}         HANGMAN           {linebreak}************************    {linebreak}________ {linebreak}|  | {linebreak}| {linebreak}| {linebreak}|  {linebreak}|   {linebreak}| {linebreak}| {linebreak}|_______ ";
        }
    }

        //Console.WriteLine(
        //    " ************************    \n
        //    "         HANGMAN           \n
        //    " ************************    \n
        //    " ________ \n
        //    " |  | \n
        //    " | ( ) \n
        //    " | /|\ \n
        //    " |  | \n
        //    " | / \ \n
        //    " | \n
        //    " | \n
        //    " |_______ \n");
        
        
    
}
