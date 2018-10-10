using FileHandlerLibrary.FileHandlers;
using ModelLibrary.Models.Set;
using ModelLibrary.Models.Topic;
using NoteTrackUI.Presenters;
using NoteTrackUI.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTrackUI.Factory
{
    public static class StaticFactory
    {
        /// <summary>
        /// Create a List<SetModel>
        /// </summary>
        /// <returns></returns>
        public static List<SetModel> CreateAllSets()
        {
            return (List<SetModel>) GetAllSets.GetAll();
        }


        /// <summary>
        /// Create MainView()
        /// </summary>
        /// <returns></returns>
        public static IMainView CreateMainView()
        {
            return new MainView();
        }


        /// <summary>
        /// Create MainViewPresenter()
        /// </summary>
        /// <returns></returns>
        public static IMainViewPresenter CreateMainViewPresenter()
        {
            return new MainViewPresenter((MainView) CreateMainView());
        }


        public static ISetListboxView CreateSetlistboxView()
        {
            return new SetListboxView();
        }


        /// <summary>
        /// Create SetlistPresenter(MainView)
        /// </summary>
        /// <returns></returns>
        public static ISetlistboxPresenter CreateSetlistboxPresenter(MainView mainView, List<SetModel> setModels)
        {
            return new SetlistboxPresenter((SetModel) CreateSetModel(), setModels, mainView, (SetListboxView)CreateSetlistboxView());
        }


        /// <summary>
        /// Create TopicModel()
        /// </summary>
        /// <returns></returns>
        public static ITopicModel CreateTopicModel()
        {
            return new TopicModel();
        }


        /// <summary>
        /// Create SetModel()
        /// </summary>
        /// <returns></returns>
        public static ISetModel CreateSetModel()
        {
            return new SetModel();
        }
        

        /// <summary>
        /// Create a AddSetPresenter(mainView, setModel, topicModel)
        /// </summary>
        /// <param name="mainView"></param>
        /// <param name="setModel"></param>
        /// <param name="topicModel"></param>
        /// <returns></returns>
        public static IAddSetPresenter CreateAddSetPresenter(MainView mainView)
        {
            return new AddSetPresenter(mainView, (SetModel)CreateSetModel(), (TopicModel) CreateTopicModel());
        }


        /// <summary>
        /// Create SetNameUpdater dialog
        /// </summary>
        /// <returns></returns>
        public static SetNameUpdater CreateSetNameUpdater()
        {
            return new SetNameUpdater();
        }


        private static SetView CreateSetView()
        {
            return new SetView();
        }


        public static SetViewPresenter CreateSetViewPresenter(MainView mainView)
        {
            return new SetViewPresenter(mainView, CreateSetView());
        }


        public static SetModel GetSelectedSetModel(string selectedSet)
        {
            SetModel _setModel = GetBySetName.GetByName(selectedSet);
            return _setModel;
        }

        public static VideoViewPresenter CreateVideoViewPresenter(MainView mainView, FileInfo file)
        {
            return new VideoViewPresenter(mainView, file);
        }
    }
}
