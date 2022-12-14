package by.iaa.myapplication

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.lifecycle.ViewModelProvider
import by.iaa.myapplication.databinding.ActivityMainBinding
import by.iaa.myapplication.fragments.AddEditFragment
import by.iaa.myapplication.fragments.ListFragment
import by.iaa.myapplication.helpers.FragmentManagerService
import by.iaa.myapplication.viewmodels.CardViewModel

class MainActivity : AppCompatActivity() {
    private lateinit var _binding : ActivityMainBinding
    private lateinit var _viewModel: CardViewModel

    private lateinit var _listFragment: ListFragment
    private lateinit var _addEditFragment: AddEditFragment

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        _binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(_binding.root)
        setSupportActionBar(_binding.toolbarLayout.toolbar)

        _viewModel = ViewModelProvider(this)[CardViewModel::class.java]

        registerListFragment()
    }

    private fun registerListFragment() {
        _listFragment = ListFragment()

        _listFragment.onAddClick = {
            _addEditFragment = AddEditFragment()
            _viewModel.contactCard.value = null

            _addEditFragment.onMovieAddOrEdit = {
                FragmentManagerService.openFragment(supportFragmentManager, R.id.frameLayout, _listFragment)
            }

            FragmentManagerService.openFragment(supportFragmentManager, R.id.frameLayout, _addEditFragment, true)
        }

        _listFragment.onEditClick = {
            _addEditFragment = AddEditFragment()
            _viewModel.contactCard.value = it
            _viewModel.isEditMode.set(true)

            _addEditFragment.onMovieAddOrEdit = {
                FragmentManagerService.openFragment(supportFragmentManager, R.id.frameLayout, _listFragment)
            }

            FragmentManagerService.openFragment(supportFragmentManager, R.id.frameLayout, _addEditFragment, true)
        }

        FragmentManagerService.openFragment(supportFragmentManager, R.id.frameLayout, _listFragment)
    }
}