package by.iaa.myapplication.viewholders

import android.view.ContextMenu
import android.view.View
import android.view.animation.AnimationUtils
import android.widget.ImageView
import androidx.cardview.widget.CardView
import androidx.databinding.ViewDataBinding
import androidx.recyclerview.widget.RecyclerView
import by.iaa.myapplication.BR
import by.iaa.myapplication.R
import by.iaa.myapplication.databinding.ListItemBinding
import by.iaa.myapplication.helpers.ImageService
import by.iaa.myapplication.models.ContactCard

class CardViewHolder constructor(private var binding: ListItemBinding) : RecyclerView.ViewHolder(binding.root), View.OnCreateContextMenuListener {
    lateinit var contactCard: ContactCard
    lateinit var cardView: CardView
    var clickCount: Int = 0

    fun bind(contactCard: ContactCard) {
        binding.setVariable(BR.contactCard, contactCard)
        ImageService.loadImageFromStorage(contactCard.Image, binding.logoImage)
        binding.card.setOnCreateContextMenuListener(this);
        this.contactCard = contactCard
        this.cardView = binding.card
        cardView.setOnClickListener {
            if(clickCount == 10) {
                cardView.startAnimation(AnimationUtils.loadAnimation(this.itemView.context, R.anim.shake))
                clickCount = 0
            } else {
                clickCount++
            }
        }
    }

    override fun onCreateContextMenu(
        menu: ContextMenu?,
        v: View?,
        menuInfo: ContextMenu.ContextMenuInfo?
    ) {
        menu?.setHeaderTitle(R.string.cardOptions)
        menu?.add(adapterPosition, R.id.item_edit, 0, R.string.edit)
        menu?.add(adapterPosition, R.id.call_phone, 0, R.string.callTheNumber)
        menu?.add(adapterPosition, R.id.open_website, 0, R.string.openWebsite)
        menu?.add(adapterPosition, R.id.item_delete, 1, R.string.delete)
    }
}