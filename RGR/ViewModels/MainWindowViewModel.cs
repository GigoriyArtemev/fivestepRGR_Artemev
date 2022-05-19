using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Reactive.Linq;
using RGR.Models;

namespace RGR.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreateTabs();
            CreateGrid();
            CreateRequests();
            Content = Fv = new FirstViewModel(this);
            Sv = new SecondViewModel(this);
        }

        public FirstViewModel Fv { get; }
        public SecondViewModel Sv { get; }

        public void Change()
        {
            if (Content == Fv)
                Content = Sv;
            else if (Content == Sv)
                Content = Fv;
        }

        ViewModelBase content;
        public ViewModelBase Content
        {
            get { return content; }
            set { this.RaiseAndSetIfChanged(ref content, value); }
        }

        ObservableCollection<Tabs> tab;
        public ObservableCollection<Tabs> Tab
        {
            get { return tab; }
            set { this.RaiseAndSetIfChanged(ref tab, value); }
        }
        private void CreateTabs()
        {
            Tab = new ObservableCollection<Tabs>();
            Tab.Add(new Tabs("игроки",false));
            Tab.Add(new Tabs("клуб", false));
            Tab.Add(new Tabs("матчи", false));
            Tab.Add(new Tabs("статистика клуба", false));
            Tab.Add(new Tabs("статистика матча", false));
            Tab.Add(new Tabs("статистика игрока", false));
            Tab.Add(new Tabs("запрос 1", true));
            Tab.Add(new Tabs("запрос 2", true));
            Tab.Add(new Tabs("запрос 3", true));

        }

        ObservableCollection<Tabs> request;
        public ObservableCollection<Tabs> Request
        {
            get { return request; }
            set { this.RaiseAndSetIfChanged(ref request, value); }
        }

        private void CreateRequests()
        {
            Request = new ObservableCollection<Tabs>();
            Request.Add(new Tabs("запрос 1", true));
            Request.Add(new Tabs("запрос 2", true));
            Request.Add(new Tabs("запрос 3", true));
        }

        ObservableCollection<Grids> grid;
        public ObservableCollection<Grids> Grid
        {
            get { return grid; }
            set { this.RaiseAndSetIfChanged(ref grid, value); }
        }
        private void CreateGrid()
        {
            Grid = new ObservableCollection<Grids>();
            Grid.Add(new Grids("Manchester City", "England"));
            Grid.Add(new Grids("Liverpool", "England"));
            Grid.Add(new Grids("Chelcea", "England"));
            Grid.Add(new Grids("Inter", "Italian"));
            Grid.Add(new Grids("Lyon", "France"));

        }



        


    }
}
