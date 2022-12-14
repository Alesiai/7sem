package by.iaa.myapplication.adapters

import android.os.Build
import android.view.LayoutInflater
import android.view.ViewGroup
import android.view.animation.AnimationUtils
import androidx.annotation.RequiresApi
import androidx.databinding.DataBindingUtil
import androidx.lifecycle.LifecycleOwner
import androidx.lifecycle.LiveData
import androidx.recyclerview.widget.RecyclerView
import by.iaa.myapplication.R
import by.iaa.myapplication.databinding.ListItemBinding
import by.iaa.myapplication.models.ContactCard
import by.iaa.myapplication.viewholders.CardViewHolder


class ContactCardsAdapter internal constructor(lifecycleOwner: LifecycleOwner, private var ContactCards: LiveData<List<ContactCard>>) :
    RecyclerView.Adapter<CardViewHolder>() {

    init {
        ContactCards.observe(lifecycleOwner) {
            notifyDataSetChanged()
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): CardViewHolder {
        val binding: ListItemBinding = DataBindingUtil.inflate(
            LayoutInflater.from(parent.context),
            R.layout.list_item,
            parent,
            false)

        return CardViewHolder(binding)
    }


    @RequiresApi(Build.VERSION_CODES.O)
    override fun onBindViewHolder(holder: CardViewHolder, position: Int) {
        val contactCard: ContactCard = ContactCards.value!![position]
        holder.bind(contactCard)

        holder.cardView.animation = AnimationUtils.loadAnimation(holder.itemView.context, R.anim.card_appear)
    }

    override fun getItemCount() = ContactCards.value?.size ?: 0

    fun onItemDelete(position: Int) {
        notifyItemRemoved(position)
    }

    @RequiresApi(Build.VERSION_CODES.O)
    fun getItem(position: Int) = ContactCards.value!![position]
}